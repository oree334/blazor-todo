using Blazored.LocalStorage;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TodoLib
{
    public class AppData
    {
        private ILocalStorageService localStore { get; set; }
        public void SetLocalStore(ILocalStorageService localStore)
        {
            this.localStore = localStore;
        }

        public async Task<List<ToDoItem>> GetTodosAsync()
        {
            var json = await localStore.GetItemAsStringAsync("todos");
            if (string.IsNullOrEmpty(json))
            {
                return new List<ToDoItem> { new ToDoItem { Text = "Test me" } };
            }
            else
            {
                return JsonSerializer.Deserialize<List<ToDoItem>>(json);
            }
        }

        public async Task SaveTodosAsync(List<ToDoItem> todos)
        {
            var json = JsonSerializer.Serialize(todos);
            await localStore.SetItemAsStringAsync("todos", json);
        }
    }
}
