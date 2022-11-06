using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SQLite;

namespace BowBuddy.Helpers {
    public static class ModelHelper {
        private const string ModelNamespace = "BowBuddy.Models";

        public static IEnumerable<Type> ModelTypes =>
            Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass &&
                            t.Namespace == ModelNamespace &&
                            t.GetCustomAttribute<TableAttribute>() != null);

    }
}