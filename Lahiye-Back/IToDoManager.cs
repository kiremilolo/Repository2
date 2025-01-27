using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiye_Back
{
    public  interface IToDoManager
    {
        ToDoItem[] ToDo { get; }

        void AddTodoItem(ToDoItem item);
        void GetAllToDoItem();
        ToDoItem[] GetAllDelayedTasks();

        void ChangeTodoItemStatus(int No, Status Status);
        // - EditTodoItem() - no,title,desc,deadline dəyərləri qəbul edir və həmin no-lu todoitem-ın title,
        // description və deadline dəyərlərini dəyişir.Bu dəyərlər optionaldır,
        // misalçün ancaq title dəyişsin istəsək desc və deadline dəyərlərini null göndərə bilərik.
        void EditToDoItem(int No, string Title = null, string Description = null, DateTime? DeadLine = new DateTime?());
        void DeleteTodoItem(int No);

        ToDoItem[] GetAllTodoItemsByStatus(Status status);

        ToDoItem[] SearchTodoItems(string search);

        ToDoItem[] FilterTodoItems(Status status, DateTime fromDate, DateTime ToDate);


        
            //- TodoItems
 //- AddTodoItem() - todoitem obyekti qəbul edib TodoItems-a əlavə edir
 //- GetAllTodoItems()
// - GetAllDelayedTasks() - deadline tarixi keçmiş və həmin tarixdən öncə done olmamış todoitemları qaytaran metod
 //- ChangeTodoItemStatus() - no və status dəyərləri qəbul edir, no dəyərli todoitem-in statusunu dəyişdirir
// - EditTodoItem() - no,title,desc,deadline dəyərləri qəbul edir və həmin no-lu todoitem-ın title, description və deadline dəyərlərini dəyişir.Bu dəyərlər optionaldır, misalçün ancaq title dəyişsin istəsək desc və deadline dəyərlərini null göndərə bilərik.
// - DeleteTodoItem() - no dəyəri qəbul edir və həmin no-lu todoitem-ı TodoItems-dan silir
// - GetAllTodoItemsByStatus() - status dəyəri qəbul edir və həmin status-lu todoitems-ları qaytarır
 //- SearchTodoItems() - string dəyər qəbul edir və title-inda həmin dəyər olan butun todoitemsları qaytarır
 //- FilterTodoItems() - status, fromDate, toDate dəyərləri qəbul edir və göndərilmiş statusda deadline dəyəri fromDate-toDate intervalında olan TodoItems-ları qaytarır (status dəyəri



    }
}
