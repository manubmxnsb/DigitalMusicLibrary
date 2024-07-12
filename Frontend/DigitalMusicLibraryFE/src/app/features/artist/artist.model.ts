export class ArtistInterface {
    public id: number;
    public name: string;
    public albums: Album[];

    constructor(id: number, name: string, albums: Album[]) {
      this.id = id;
      this.name = name;
      this.albums = albums;
    }
}
export class Album {
    public id: number;
    public title: string;
    public description: string;
    public songs: Song[];

    constructor(id: number, title: string, description: string, songs: Song[]) {
        this.id = id;
        this.title = title;
        this.description = description;
        this.songs = songs;
      }
  }
  
  export class Song {
    public id: number;
    public title: string;
    public length: string;

    constructor(id: number, title: string, length: string)
    {
        this.id = id;
        this.title = title;
        this.length = length;
    }
  }
  