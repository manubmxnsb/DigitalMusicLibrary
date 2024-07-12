import { createFeatureSelector, createSelector } from "@ngrx/store";
import { ArtistStateInterface } from "../interfaces/artists.interface";


export const selectFeature = createFeatureSelector<ArtistStateInterface>('Artists');
export const selectArtistState = createFeatureSelector<ArtistStateInterface>('Artist');

export const isLoadingSelector = createSelector(
    selectFeature,
    (state) => state.isLoading
);
export const ArtistsSelector = createSelector(
    selectFeature,
    (state) => state.Artists
);
export const errorSelector = createSelector(
    selectFeature,
    (state) => state.error
);
export const getSelectedArtist = createSelector(
    selectArtistState,
    (state: ArtistStateInterface) => state.selectedArtist
  );

export const getArtistById = (id: number) =>
    createSelector(
      selectArtistState,
      (state: ArtistStateInterface) => state.Artists.find(artist => artist.id === id)
    );
  