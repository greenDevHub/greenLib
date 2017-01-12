Select buch_isbn as 'ISBN', buch_titel as 'Titel', zu_zustand 'Zustand', bes_ist as 'Istbestand', bes_soll as 'Sollbestand', au_autor as 'Autor',
ver_name as 'Verlag' from t_s_buecher
left join t_s_zustand on buch_zustand_id=zu_id
left join t_s_bestand on buch_bestand_id=bes_id
left join t_s_autor on buch_autor_id=au_id
left join t_s_verlag on buch_verlag_id=ver_id