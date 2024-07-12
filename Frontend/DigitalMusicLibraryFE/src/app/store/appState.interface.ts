import { ArtistInterface } from "../features/artist/artist.model";
import { ArtistStateInterface } from "./interfaces/artists.interface";

export interface AppStateInterface {
    Artist: {
        selectedArtist: ArtistInterface | null;
}}