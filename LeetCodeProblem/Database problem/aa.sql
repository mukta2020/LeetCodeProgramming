-- Write a solution to find the nth highest distinct salary from the Employee table

SELECT DISTINCT e.salary
    FROM Employee e
    ORDER BY e.salary DESC
    LIMIT 1 OFFSET (N - 1);
