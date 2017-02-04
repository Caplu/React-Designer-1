﻿using System.Collections.Generic;
using System.Linq;

namespace ReactDesigner.TaskRunner
{
    class Constants
    {
        public const string FILENAME = "package.json";
        public const string NPM_CLI_COMMAND = "npm";
        public const string NPM_VERBOSE_OPTION = "-d";
        public const string POST_SCRIPT_PREFIX = "post";
        public const string PRE_SCRIPT_PREFIX = "pre";
        public const string YARN_CLI_COMMAND = "yarn";
        public const string YARN_VERBOSE_OPTION = "--verbose";

        public static readonly string[] NPM_ALWAYS_TASKS = { "install", "update" };
        public static readonly string[] YARN_ALWAYS_TASKS = { "install", "upgrade" };

        public static readonly string[] NPM_DEFAULT_TASKS = { "test", "uninstall", "restart", "start", "stop", "version" };
        public static readonly string[] YARN_DEFAULT_TASKS = { "test", "version" };

        public static readonly string[] RESTART_SCRIPT_TASKS = { "prerestart", "prestop", "stop", "poststop", "restart", "prestart", "start", "poststart", "postrestart" };

        public static readonly IEnumerable<string> NPM_ALL_DEFAULT_TASKS = NPM_ALWAYS_TASKS.Union(NPM_DEFAULT_TASKS);
        public static readonly IEnumerable<string> YARN_ALL_DEFAULT_TASKS = YARN_ALWAYS_TASKS.Union(YARN_DEFAULT_TASKS);
    }
}
