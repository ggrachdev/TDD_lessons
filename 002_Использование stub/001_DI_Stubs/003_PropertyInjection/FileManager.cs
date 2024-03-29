﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_PropertyInjection
{
    class FileManager
    {
        IDataAccessObject dataAccessObject;

        public FileManager()
        {
        }

        // Свойство, через которое будет внедрена зависимость.
        public IDataAccessObject DataAccessObject
        {
            set { dataAccessObject = value; }
            get 
            {
                if (dataAccessObject == null)
                {
                    throw new MemberAccessException("DataAccessObject has not been initialized.");
                }
                return dataAccessObject; 
            }
        }

        public bool FindLogFile(string fileName)
        {
            List<string> files = DataAccessObject.GetFiles();

            foreach (var file in files)
            {
                if (file.Contains(fileName))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
