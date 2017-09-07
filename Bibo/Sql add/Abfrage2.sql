Select aus_leihnummer as 'Leihnummer', buch_id as 'Buch-ID', buch_titel as 'Buchtitel', aus_leihdatum as 'Ausleihdatum', aus_rückgabedatum as 'Voraussichtliches Rückgabedatum', 
kunde_id as 'Kunden-ID', kunde_vorname as 'Vorname', kunde_nachname as 'Nachname' from t_s_ausgeliehen
left join t_s_buecher on aus_buchid=buch_id
left join t_s_kunden on aus_kundenid=kunde_id
