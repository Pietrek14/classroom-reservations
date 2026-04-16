using dpiotrowski_lab2.Model.Employees;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace dpiotrowski_lab2.Model
{
    public class ObjectListSerializer<TList, TElement> where TList : IObjectList<TElement>, new() where TElement : IGuided
    {
        private string filePath;

        public ObjectListSerializer(string filePath) {
            this.filePath = filePath;
        }

        public void Serialize(TList objectList)
        {
            string jsonString = JsonSerializer.Serialize(objectList.Elements);

            File.WriteAllText(this.filePath, jsonString);
        }

        public TList? Deserialize()
        {
            try
            {
                string jsonString = File.ReadAllText(this.filePath);

                if (jsonString == "")
                {
                    return default(TList?);
                }

                var elements = JsonSerializer.Deserialize<List<TElement>>(jsonString);
                if (elements == null)
                {
                    return default(TList?);
                }

                var objectList = new TList();
                foreach (var element in elements)
                {
                    objectList.Add(element);
                }

                return objectList;
            }
            catch (FileNotFoundException)
            {
                return default(TList?);
            }
        }
    }
}
