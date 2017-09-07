select bu_isbn,
	count(*) as Sollbestand
	from t_s_buchid
	Group by bu_isbn;

select aus_buchid,
	count(*) as Istbestand
	from t_bd_ausgeliehen
	group by aus_buchid

