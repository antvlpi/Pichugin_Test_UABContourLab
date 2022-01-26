SELECT em1.chief_id ID_руководителя, em1.name ФИО, em1.salary ЗП, de.name Отдел FROM Employee AS em1
INNER JOIN Employee AS em2
ON em1.chief_id = em2.id
INNER JOIN Department AS de
ON em1.department_id = de.id
WHERE (em1.chief_id = em2.id and em1.salary > em2.salary)