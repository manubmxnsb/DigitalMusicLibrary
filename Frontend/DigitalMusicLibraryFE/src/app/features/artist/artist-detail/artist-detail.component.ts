import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Album, ArtistInterface } from '../artist.model';
import { ArtistService } from '../artist.service';
import { Observable, combineLatest } from 'rxjs';
import { select, Store } from '@ngrx/store';
import { getSelectedArtist } from 'src/app/store/selectors/artist.selectors';
import * as ArtistActions from '../../../store/actions/artists.actions';
import { AppStateInterface } from '../../../store/appState.interface';
import { debounceTime, distinctUntilChanged, map } from 'rxjs/operators';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-artist-detail',
  templateUrl: './artist-detail.component.html',
  styleUrls: ['./artist-detail.component.scss']
})
export class ArtistDetailComponent implements OnInit {
    $Artist: Observable<ArtistInterface | null>;
    $Albums: Observable<Album[]>;
    searchTerm: FormControl = new FormControl(''); // Initialize searchTerm as a FormControl
    $filteredAlbums: Observable<Album[]>;

    constructor(
      private route: ActivatedRoute,
      private artistService: ArtistService,
      private store: Store<AppStateInterface>
    ) {
      this.$Artist = this.store.pipe(select(getSelectedArtist));
      this.$Albums = this.store.pipe(select(state => state.Artist.selectedArtist?.albums || []));

      // Use combineLatest to listen to changes in $Albums and searchTerm
      this.$filteredAlbums = combineLatest([
        this.$Albums,
        this.searchTerm.valueChanges.pipe(
          debounceTime(300),
          distinctUntilChanged()
        )
      ]).pipe(
        map(([albums, searchTerm]) => {
          if (!searchTerm.trim()) {
            return albums;
          } else {
            const lowerCaseTerm = searchTerm.toLowerCase();
            return albums.filter(album =>
              album.title.toLowerCase().includes(lowerCaseTerm)
            );
          }
        })
      );
    }

    ngOnInit(): void {
      const artistId = this.route.snapshot.paramMap.get('id');
      if (artistId) {
        this.store.dispatch(ArtistActions.getArtist({ id: Number(artistId) }));
      }
    }
}