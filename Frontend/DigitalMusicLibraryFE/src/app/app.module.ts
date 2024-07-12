import { NgModule, isDevMode } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StoreModule } from '@ngrx/store';
import { EffectsModule } from '@ngrx/effects';
import { ArtistEffects } from './store/effects/artists.effects';
import { ArtistReducer } from './store/reducers/artists.reducer';
import { ArtistModule } from './features/artist/artist.module';
import { StoreDevtoolsModule } from '@ngrx/store-devtools';
import { ArtistService } from './features/artist/artist.service';
import { HeaderComponent } from './features/header/header.component';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
  ],
  imports: [
    FormsModule,
    BrowserModule,
    ArtistModule,
    AppRoutingModule,
    HttpClientModule,
    StoreModule.forRoot({
      Artist:ArtistReducer
    }),
    StoreDevtoolsModule.instrument({
      maxAge: 25, // Retains last 25 states
      autoPause: true,
    }),
    EffectsModule.forRoot([ArtistEffects]),
    StoreDevtoolsModule.instrument({ maxAge: 25, logOnly: !isDevMode() }),
    BrowserAnimationsModule
  ],
  providers: [ArtistService],
  bootstrap: [AppComponent]
})
export class AppModule { }
