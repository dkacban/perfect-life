# language: pl

Właściwość:
	Jako użytkownik aplikacji mobilnej 
	chcę ekran logowania 
	aby mieć możliwość zapisywania swoich postępów

Scenariusz: Prawidłowe logowanie do aplikacji
	Mając aktywne konto google
	Jeśli na ekranie logowania podam swój login i hasło
	I zatwierdze dane odpowiednim przyciskiem
	Wtedy będę miał dostęp do wszystkich funkcjonalności aplikacji

Scenariusz: Nieprawidłowe logowanie do aplikacji
	Mając brak konta google
	Jeśli na ekranie logowania podam nieistniejący login i hasło
	I zatwierdze dane odpowiednim przyciskiem
	Wtedy nie będę miał dostępu do żadnej funkcjonalności aplikacji
	I zostanę przeniesiony na ekran mówiący o nieudanej próbie logowania

