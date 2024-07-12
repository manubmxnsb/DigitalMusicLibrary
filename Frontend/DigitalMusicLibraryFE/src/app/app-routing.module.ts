import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ArtistModule } from './features/artist/artist.module';
import { ArtistComponent } from './features/artist/artist.component';
import { ArtistDetailComponent } from './features/artist/artist-detail/artist-detail.component';

const routes: Routes = [
    { path: '', redirectTo: '/artists', pathMatch: 'full' },
    { path: 'artists', component: ArtistComponent },
  { path: 'artist/:id', component: ArtistDetailComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
