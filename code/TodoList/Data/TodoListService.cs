using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Model;
using System.Diagnostics;
namespace TodoList.Data
{
    public class TodoListService
    {
        private List<Todo> TodoList;
        private string _pathJsonFile = @"Resources\DataTodoList.json";

        //fetch all Todo in File Json Data to this.TodoList
        public void FetchTodoListData()
        {
            using (StreamReader r = new StreamReader(_pathJsonFile))
            {
                string json = r.ReadToEnd();
                JObject o = JObject.Parse(json);
                JArray aTodos = (JArray)o["Todos"];

                TodoList = new List<Todo>();//reset this.TodoList before add new Data by FileJson

                foreach (var todo in aTodos)
                {
                    TodoList.Add(new Todo() { Id = (int)todo["Id"], Text = (string)todo["Text"], Done = (bool)todo["Done"] });
                }
            }
        }

        //get all Todo
        public Task<Todo[]> GetTodoAsync()
        {
            FetchTodoListData();//update this.TodoList from data by file Json
            return Task.FromResult(TodoList.ToArray());
        }

        //add Todo
        public Task<bool> AddTodoAsync(string text)
        {
            try
            {
                JArray arr_todos;
                using (StreamReader r = new StreamReader(_pathJsonFile))
                {
                    //get all data in file json
                    string json = r.ReadToEnd();
                    JObject o = JObject.Parse(json);
                    arr_todos = (JArray)o["Todos"];

                    //create new object Todo
                    JObject temp_todo = new JObject
                    {
                        { "Id",  (int)arr_todos[arr_todos.Count-1]["Id"] + 1 },//Get Id of Last Todo and +1 to create new Id
                        { "Text", text },
                        { "Done", false }
                    };
                    arr_todos.Add(temp_todo);
                }
                // write JSON directly to a file
                using (StreamWriter file = File.CreateText(_pathJsonFile))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("Todos");
                    arr_todos.WriteTo(writer);
                }
                return Task.FromResult(true);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }
        //change state Todo

        //edit Todo

        //delete Todo
        public Task<bool> DeleteTodoAsync(int id)
        {
            try
            {
                JArray arr_todos;
                //find Todo in Data by id
                using (StreamReader r = new StreamReader(_pathJsonFile))
                {
                    //get all data in file json
                    string json = r.ReadToEnd();
                    JObject o = JObject.Parse(json);
                    arr_todos = (JArray)o["Todos"];

                    JArray temp_arr_todos = arr_todos;
                    for (int i = 0; i <= arr_todos.Count; i++)
                    {
                        if((int)temp_arr_todos[i]["Id"] == id)
                        {
                            temp_arr_todos[i].Remove();
                            break;
                        }
                        else
                        {
                            //Id khong ton tai
                            return Task.FromResult(false);
                        }
                    }
                    arr_todos = temp_arr_todos;
                }
                // write JSON directly to a file
                using (StreamWriter file = File.CreateText(_pathJsonFile))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("Todos");
                    arr_todos.WriteTo(writer);
                }
                return Task.FromResult(true);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }
    }
}
