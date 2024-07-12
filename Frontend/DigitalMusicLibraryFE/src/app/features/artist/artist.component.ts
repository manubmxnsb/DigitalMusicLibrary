import { Component, OnInit } from '@angular/core';
import { ArtistInterface } from './artist.model';
import { Observable } from 'rxjs';
import { Store, select } from '@ngrx/store';
import { ArtistService } from './artist.service';
import { ArtistsSelector, errorSelector, isLoadingSelector } from '../../store/selectors/artist.selectors';
import * as ArtistActions from '../../store/actions/artists.actions';
import { Router } from '@angular/router';


@Component({
  selector: 'app-Artist',
  templateUrl: './Artist.component.html',
  styleUrls: ['./Artist.component.scss']
})
export class ArtistComponent implements OnInit{
  displayedColumns: string[] = ['name'];
  $isLoading: Observable<boolean>;
  $error: Observable<string | null>;
  $Artists: Observable<ArtistInterface[]>;

  constructor(private store:Store, public ArtistService:ArtistService, private router: Router) {
    this.$isLoading = this.store.pipe(select(isLoadingSelector));
    this.$error = this.store.pipe(select(errorSelector));
    this.$Artists = this.store.pipe(select(ArtistsSelector));
  }
  ngOnInit() {
    this.store.dispatch(ArtistActions.getArtists());
  }
  viewArtistDetail(artistId: number): void {
    this.router.navigate(['/artist', artistId]);
  }

}
