import { Injectable, OnInit } from '@angular/core';
import { Observable, delay, map, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { ArtistInterface } from './artist.model';

@Injectable({providedIn: 'root'})
export class ArtistService {
    private readonly ROOT_URL = 'http://localhost:5130/api/Artists';
  constructor(private http: HttpClient) {}

  getArtists(): Observable<ArtistInterface[]> {
    console.log(this.http.get<ArtistInterface[]>("http://localhost:5130/api/Artists/all".toString()));
    return this.http.get<ArtistInterface[]>("http://localhost:5130/api/Artists/all");
  }
  getArtistById(id: number): Observable<ArtistInterface> {
    return this.http.get<ArtistInterface>(`${this.ROOT_URL}/${id}`);
  }
}