using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using SDILReader;

namespace MSIL
{
    public class TypesHelper
    {
        /// <summary>
        /// Gets the types from given assembly ordered by name.
        /// </summary>
        /// <param name="inAssembly"></param>
        /// <returns>List&lt;Type&gt;</returns>
        public static List<Type> GetTypes(Assembly inAssembly)
        {
            if (inAssembly == null)
            {
                throw new NullReferenceException("[GetTypes]: Input argument (assembly) is null!");
            }
            return inAssembly.GetTypes().OrderBy(t => t.Name).ToList();
        }
        /// <summary>
        /// Gets the methods from given type ordered by name
        /// </summary>
        /// <param name="inType"></param>
        /// <returns>List&lt;MethodInfo&gt;</returns>
        public static List<MethodInfo> GetMethodInfos(Type inType)
        {
            if (inType == null)
            {
                throw new NullReferenceException("[GetMethodInfos]: Input type  is null!");
            }
            return inType.GetMethods().OrderBy(m=>m.Name).ToList();
        }

        /// <summary>
        /// Gets the list of IL Instructions from methodinfo.
        /// code by Sorin Serban
        /// http://www.codeproject.com/Articles/14058/Parsing-the-IL-of-a-Method-Body
        /// </summary>
        /// <param name="methodInfo"></param>
        /// <returns>List&lt;ILInstruction&gt;</returns>
        public static List<ILInstruction> GetILInstructions(MethodInfo methodInfo)
        {
            Globals.LoadOpCodes();
            MethodBodyReader _reader = new SDILReader.MethodBodyReader(methodInfo);
            _reader.GetBodyCode();
            return _reader.instructions;
        }

    }
}
