﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_InterfaceInjection
{
    class FileManager
    {
        public bool FindLogFile(string fileName, IDataAccessObject dataAccessObject)
        {
            if (dataAccessObject == null)
            {
                throw new ArgumentNullException("dataAccessObject", "Parameter dataAcessObject cannot be null");
            }

            List<string> files = dataAccessObject.GetFiles();

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
