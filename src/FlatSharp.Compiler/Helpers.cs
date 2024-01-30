﻿/*
 * Copyright 2021 James Courtney
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace FlatSharp.Compiler;

public static class Helpers
{
    public static (string ns, string typeName) ParseName(string name)
    {
        name = name.Trim();

        int lastIndex = name.LastIndexOf('.');
        if (lastIndex == -1)
        {
            ErrorContext.Current.RegisterError($"Type '{name}' not within a namespace.");
            return ("TempNs", name);
        }

        return (name.Substring(0, lastIndex), name.Substring(lastIndex + 1));
    }

    public static string Visibility(CompileContext context)
    {
        if (context.Options.InternalTypes)
        {
            return "internal";
        }

        return "public";
    }
}
