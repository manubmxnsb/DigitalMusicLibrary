import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { catchError, map, mergeMap, of } from "rxjs";
import { ArtistService } from "../../features/artist/artist.service";
import * as ArtistActions from '../../store/actions/artists.actions';


@Injectable()
export class ArtistEffects {
    getArtists$ = createEffect(() =>
      this.actions$.pipe(
        ofType(ArtistActions.getArtists),
        mergeMap(() =>
          this.artistService.getArtists().pipe(
            map(artists => ArtistActions.getArtistsSuccess({ Artists: artists })),
            catchError(error => of(ArtistActions.getArtistsFailure({ error: 'Failed to get artists' })))
          )
        )
      )
    );

    getArtist$ = createEffect(() =>
        this.actions$.pipe(
          ofType(ArtistActions.getArtist),
          mergeMap(action =>
            this.artistService.getArtistById(action.id).pipe(
              map(artist => ArtistActions.getArtistSuccess({ artist })),
              catchError(error =>
                of(ArtistActions.getArtistFailure({ error: 'Action Get Artist Failed' }))
              )
            )
          )
        )
      );
    constructor(private actions$ : Actions, private artistService: ArtistService) {}
}
