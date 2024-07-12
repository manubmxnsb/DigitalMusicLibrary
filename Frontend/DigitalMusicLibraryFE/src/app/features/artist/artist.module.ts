import { CommonModule } from "@angular/common";
import { MatTableModule } from "@angular/material/table";
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { StoreModule } from "@ngrx/store";
import { ArtistService } from "./artist.service";
import { ArtistComponent } from "./artist.component";
import { NgModule } from "@angular/core";
import { ArtistReducer } from "../../store/reducers/artists.reducer";
import { ArtistDetailComponent } from "./artist-detail/artist-detail.component";
import { RouterModule } from "@angular/router";

@NgModule({
    imports: [CommonModule,
        MatTableModule,
        FormsModule,
        RouterModule,
        MatFormFieldModule,
        MatInputModule,
        ReactiveFormsModule,
        StoreModule.forFeature('Artists', ArtistReducer)],
    providers: [ArtistService],
    declarations: [ArtistComponent, ArtistDetailComponent],
    exports: [ArtistComponent, MatInputModule],
})
export class ArtistModule {}