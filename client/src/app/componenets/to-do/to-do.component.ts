import { Component, OnInit } from '@angular/core';
import { faTrash } from '@fortawesome/free-solid-svg-icons';
import { faPlus } from '@fortawesome/free-solid-svg-icons';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Component({
  selector: 'app-to-do',
  templateUrl: './to-do.component.html',
  styleUrls: ['./to-do.component.css']
})

export class ToDoComponent implements OnInit {
  
  //Api location and http format options
  readonly ROOT_URL = "http://localhost:56249/api/todos";
  private httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json',
    })
  };

  constructor(private http: HttpClient) { }

  todos: any;
  
  getTodos(): any {
   this.todos = this.http.get(this.ROOT_URL);
  }

  faTrash = faTrash;
  faPlus = faPlus;

  todoText: string = '';
  
  addToDo(){
    
    if(this.todoText !== "") {
      var data = JSON.stringify({id: Math.floor(Math.random() * 99999999), TodoText: this.todoText, Done: false});
      this.todos = this.http.post(this.ROOT_URL, data, this.httpOptions);
    }
  this.todoText = "";
  }

  deleteTodo(id: any) {
    this.todos = this.http.delete(this.ROOT_URL + "/" + id);
  }

  changeDone(id: any) {
    this.todos = this.http.get(this.ROOT_URL + "/" + id);
  }

  ngOnInit(): void {
    this.getTodos();
  }

}

