import { createReducer, on } from '@ngrx/store';
import { ArtistStateInterface } from '../interfaces/artists.interface';
import * as ArtistActions from '../actions/artists.actions';


const initialArtistsState: ArtistStateInterface = {
  isLoading: false,
  Artists: [],
  selectedArtist: null,
  error: null,
};

export const ArtistReducer = createReducer(
    initialArtistsState,
  on(ArtistActions.getArtists, (state) => ({ ...state, isLoading: true })),
  on(ArtistActions.getArtistsSuccess, (state, action) => ({
    ...state,
    isLoading: false,
    Artists: action.Artists,
  })),
  on(ArtistActions.getArtistsFailure, (state, action) => ({
    ...state,
    isLoading: false,
    error: action.error,
  })),
  on(ArtistActions.getArtistSuccess, (state, { artist }) => ({
    ...state,
    selectedArtist: artist,
    isLoading: false,
    error: null
  })),
);
