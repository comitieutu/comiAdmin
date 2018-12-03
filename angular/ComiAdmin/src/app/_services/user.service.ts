import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {environment} from '../../environments/environment';
import { User } from '../_models';

@Injectable({ providedIn: 'root' })
export class UserService {
    private config: string;
    constructor(private http: HttpClient) {
        this.config = environment.apiUrl;
    }

    getAll() {
        return this.http.get<User[]>(`${this.config}/users`);
    }

    getById(id: number) {
        return this.http.get(`${this.config}/users/${id}`);
    }

    register(user: User) {
        return this.http.post(`${this.config}/users/register`, user);
    }

    update(user: User) {
        return this.http.put(`${this.config}/users/${user.id}`, user);
    }

    delete(id: number) {
        return this.http.delete(`${this.config}/users/${id}`);
    }
}