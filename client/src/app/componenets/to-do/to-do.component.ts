import { Component, OnInit } from '@angular/core';
import { faTrash } from '@fortawesome/free-solid-svg-icons';
import { faPlus } from '@fortawesome/free-solid-svg-icons';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-to-do',
  templateUrl: './to-do.component.html',
  styleUrls: ['./to-do.component.css']
})
export class ToDoComponent implements OnInit {
  
  readonly ROOT_URL = "http://localhost:56249/api/todos";


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
      this.todos.push({id: Math.floor(Math.random() * 9999999999), done: false, text: this.todoText})
      console.log(this.todos);
    }
    this.todoText = "";
  }

  // deleteTodo(id: any) {
  //   this.todos.splice(this.todos.findIndex(element => element.id == id), 1);
  // }

  // changeDone(id: any) {
  //   id = this.todos.findIndex(element => element.id == id)
  //   this.todos[id].done =  !this.todos[id].done;
  // }

  ngOnInit(): void {
    this.getTodos();
  }

}

