select id, name from departments where
exists
(select department_id from sales where price > 98 and departments.id = sales.department_id)