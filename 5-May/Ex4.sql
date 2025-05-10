Begin Transaction;
update Employees 
set Salary =Salary +2000
where Department ='IT';
commit;