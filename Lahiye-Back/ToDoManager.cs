using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lahiye_Back
{
    internal class ToDoManager : ToDoItem, IToDoManager
    {


        private ToDoItem[] _todoitem = new ToDoItem[0];

        public ToDoItem[] ToDoItems => _todoitem;

        public ToDoItem[] ToDo => throw new NotImplementedException();

        public void AddTodoItem(ToDoItem item)
        {
            Array.Resize(ref _todoitem, _todoitem.Length + 1);
            _todoitem[_todoitem.Length - 1] = item;
        }

        public void GetAllToDoItem()
        {
            foreach (var item in _todoitem)
            {
                Console.WriteLine(item);
            }
        }
        public ToDoItem[] GetAllDelayedTasks()
        {
            ToDoItem[] todo = new ToDoItem[0];
            foreach (var item in _todoitem)
            {
                if (item.DeadLine < DateTime.Now)
                {
                    Array.Resize(ref todo, todo.Length + 1);
                    todo[todo.Length - 1] = item;

                }

            }
            return todo;

        }

        public void ChangeTodoItemStatus(int no, Status status)
        {
            for (int i = 0; i < _todoitem.Length; i++)
            {
                if (_todoitem[i].No == no)
                {
                    _todoitem[i].StatusChangedAt = DateTime.Now;
                    _todoitem[i].status = status;
                }
            }
        }

        public void EditToDoItem(int No, string title = null, string Description = null, DateTime? DeadLine = null)
        {
            foreach (var item in _todoitem)
            {
                if (item.No == No)
                {
                    if (Title != null)
                        item.Title = title;
                    if (Description != null)
                        _todoitem[item.No].Description = Description;
                    if (DeadLine != null)
                        item.DeadLine = DeadLine;
                }
            }
        }
        public void DeleteTodoItem(int No)
        {
            if (No < 0 || No > _todoitem.Length)
                throw new IndexOutOfRangeException();

            for (int i = No; i < _todoitem.Length - 1; i++)
            {
                var swapper = _todoitem[i];
                _todoitem[i] = _todoitem[i + 1];
                _todoitem[i + 1] = swapper;
            }
            Array.Resize(ref _todoitem, _todoitem.Length - 1);


        }
        public ToDoItem[] GetAllTodoItemsByStatus(Status Status)
        {
            ToDoItem[] newArr = new ToDoItem[0];
            foreach (var item in _todoitem)
            {
                if (item.status == Status)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = item;
                }
            }
            return newArr;
        }

        public ToDoItem[] SearchTodoItems(string search)
        {
            ToDoItem[] newArr = new ToDoItem[0];
            foreach (var item in _todoitem)
            {
                if (item.Title == search)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = item;
                }
            }

            return newArr;
        }



        public ToDoItem[] FilterTodoItems(Status status, DateTime fromDate, DateTime ToDate)
        {
            ToDoItem[] newArr = new ToDoItem[0];
            if (status != null && fromDate != null && ToDate != null)
            {
                foreach (var item in _todoitem)
                {
                    if (item.status == status)
                    {
                        if (item.DeadLine >= fromDate && item.DeadLine <= ToDate)
                        {
                            Array.Resize(ref newArr, newArr.Length + 1);
                            newArr[newArr.Length - 1] = item;
                        }
                    }

                }


            }
            return newArr;
        }
        public void GetInfo(ToDoItem[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine($"No - {item.No}");
                Console.WriteLine($"{item.Title}");
                Console.WriteLine($"{item.Description}");
                Console.WriteLine($"{item.DeadLine}");
            }
        }
    }
}
