import { ArtistInterface } from "../../features/artist/artist.model";

export interface ArtistStateInterface {
    isLoading : boolean;
    Artists : ArtistInterface[];
    selectedArtist: ArtistInterface | null;
    error : string | null;
}