﻿using System;
using SoftwarePlannerLibrary.DataAccess;
using SoftwarePlannerLibrary.Databases.Interfaces;

namespace SoftwarePlannerLibrary.Databases
{
    public class TasksControl
    {
        private readonly PlannerContext _context;
        private readonly IRolesControl _rolesControl;

        public TasksControl(PlannerContext context,
                            IRolesControl rolesControl)
        {
            _context = context;
            _rolesControl = rolesControl;
        }
    }
}
