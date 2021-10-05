import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-to-do',
  templateUrl: './to-do.component.html',
  styleUrls: ['./to-do.component.css']
})
export class ToDoComponent implements OnInit {

  todoText: string = '';
  todos = [{id: 0, done: false, text: "test"}];

  addToDo(){
    this.todos.push({id: this.todos.length, done: false, text: this.todoText})
    this.todoText = "";
  }

  changeDone(id: any) {
    this.todos[id].done =  !this.todos[id].done;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
