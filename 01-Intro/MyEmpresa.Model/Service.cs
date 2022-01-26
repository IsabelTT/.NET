using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace MyEmpresa.Model
{
    public class Service
    {
        public void LoadData()
        {
            //Fichero incrustado dentro de un archivo de recursos
            //string json = BitConverter.ToString(Resources.Resource.LoadData);
            //var items = JsonConvert.DeserializeObject<List<Division>>(json);
            
            //Leer un fichero json https://stackoverflow.com/questions/13297563/read-and-parse-a-json-file-in-c-sharp
            //Obtener ruta https://stackoverflow.com/questions/17357109/how-to-get-the-root-directory

            //using (StreamReader r = new StreamReader("C:\\net\\Code House\\BackEndDotNet\\MyEmpresa.Model\\Resources\\LoadData.json"))
            //{
            //    string json = r.ReadToEnd();
            //    List<Division> items = JsonConvert.DeserializeObject<List<Division>>(json);
            //}
        }
    }
}
