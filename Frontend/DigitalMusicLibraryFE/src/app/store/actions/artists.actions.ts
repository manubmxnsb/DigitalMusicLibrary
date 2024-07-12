import { createAction, props } from '@ngrx/store';
import { ArtistInterface } from '../../features/artist/artist.model';

export const getArtists = createAction('[Artists] Get Artists');
export const getArtistsSuccess = createAction('[Artists] Get Artists Success', props<{Artists:ArtistInterface[]}>());
export const getArtistsFailure = createAction('[Artists] Get Artists Failure', props<{error:string}>());

export const getArtist = createAction('[Artist] Get Artist',props<{ id: number }>());
export const getArtistSuccess = createAction('[Artist] Get Artist Success',props<{ artist: ArtistInterface }>());
export const getArtistFailure = createAction('[Artist] Get Artist Failure',props<{ error: string }>());