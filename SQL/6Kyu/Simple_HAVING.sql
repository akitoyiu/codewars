select age, count(id) as total_people from people
group by age
having count(id) >= 10