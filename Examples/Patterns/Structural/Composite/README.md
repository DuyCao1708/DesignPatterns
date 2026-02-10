# Composite Pattern

1. Intent

   Lets you compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.

2. The Context (Problem)
   
   You are building an HR Management System for a global corporation:

    - Individual Employees: Software Engineers, Designers, Accountants.

    - Departments: Development Dept, Marketing Dept, HR Dept.

   The Problem: A Department is a collection of Employees, but it can also contain other sub-departments.

    - If you want to calculate the Total Salary of the "Engineering Department," you have to manually loop through every employee, then check if there are sub-teams (like "Mobile Team" or "DevOps Team"), and loop through them too.

    - Your code becomes a mess of nested foreach loops and if (isDepartment) checks.
