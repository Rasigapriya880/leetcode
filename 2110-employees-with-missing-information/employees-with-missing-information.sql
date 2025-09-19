# Write your MySQL query statement below
# Write your MySQL query statement below
/*SELECT Employees.employee_id AS employee_id
FROM Employees
LEFT JOIN Salaries
  ON (Employees.employee_id = Salaries.employee_id)
WHERE Salaries.employee_id IS NULL;*/

/*SELECT Customers.name AS Customers
FROM Customers
LEFT JOIN Orders
  ON (Customers.id = Orders.customerId)
WHERE Orders.id IS NULL;*/
# Write your MySQL query statement below
SELECT employee_id
FROM Employees
WHERE employee_id NOT IN (SELECT employee_id FROM Salaries)

UNION

SELECT employee_id
FROM Salaries
WHERE employee_id NOT IN (SELECT employee_id FROM Employees) order by employee_id ;
