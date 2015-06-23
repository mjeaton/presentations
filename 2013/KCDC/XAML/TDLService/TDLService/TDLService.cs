using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using IntroToXAMLWithWPF.Models;

namespace IntroToXAMLWithWPF.Service
{
    public class TdlService : ITdlService
    {
        private const string DataFolder = "ToDoListData";
        private string _baseFolder;
        public TdlService()
        {
			_baseFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DataFolder);
            if (!Directory.Exists(_baseFolder))
                Directory.CreateDirectory(_baseFolder);
        }

        public List<ToDoListItem> GetAllTasks(bool includeArchived)
        {
            var returnVal = new List<ToDoListItem>();
            var files = Directory.GetFiles(_baseFolder, "*.xml");

            foreach (var f in files)
            {
                returnVal.Add(new ToDoListItem() { Title = f });
            }

            return returnVal;
        }

        public List<ToDoListItem> GetTasksForOwner(Person owner, bool includeArchived)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public ToDoListItem GetNewToDoItem(string title, string description, DateTime dueDate)
        {
            return new ToDoListItem() { Title = title, UniqueId = Guid.NewGuid(), Description = description, DueDate = dueDate, Priority = Priority.Medium };
        }

        public void SaveTask(ToDoListItem itemToSave)
        {
            var fileName = Path.Combine(_baseFolder, itemToSave.Title);
            SerializeObject<ToDoListItem>(itemToSave, fileName);
        }

        public void DeleteTask(ToDoListItem itemToDelete)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        private void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }
        }

        private T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                string attributeXml = string.Empty;

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                        reader.Close();
                    }

                    read.Close();
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }

            return objectOut;
        }
    }
}