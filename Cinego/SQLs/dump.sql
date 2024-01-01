use newtest


delete from Cinemas
delete from Actors
delete from Directors
delete from Movies
delete from Actors_Movies


set identity_insert Cinemas on
insert into Cinemas(Id,Brandlogo,Name,CinemaInfo) values (1,'https://www.arcadiumsinemalari.com.tr/images/logo/logo2.png',N'Arcadium Sinemaları',N'Koru Mah. 2432 CD. No:192/121 Çankaya /Ankara')
insert into Cinemas(Id,Brandlogo,Name,CinemaInfo) values (2,'https://6a25bbd04bd33b8a843e-9626a8b6c7858057941524bfdad5f5b0.ssl.cf5.rackcdn.com/styles/movie_1500x580/rcf/press/234.png?itok=Ii7mmdQr',N'ANKAmall IMAX',N'Gazi Mah. Mevlana Blv. No:2 Ankamall AVM, 06560 Yenimahalle/Ankara')
insert into Cinemas(Id,Brandlogo,Name,CinemaInfo) values (3,'https://www.buyulufener.com.tr/img/logo_web.png',N'Büyülü Fener - KIZILAY',N'Kocatepe Mh., Meşrutiyet Cad., Hatay Sk. No:18, 06420 Çankaya/Ankara')
insert into Cinemas(Id,Brandlogo,Name,CinemaInfo) values (4,'https://www.buyulufener.com.tr/img/logo_web.png',N'Büyülü Fener - Bahçelievler',N'Yukarı Bahçelievler, Aşkabat Cad. (7. Cad.) 66.Sk (18.Sk), 06490 Çankaya/Ankara')
insert into Cinemas(Id,Brandlogo,Name,CinemaInfo) values (5,'https://www.paribucineverse.com/assets/img/logo/logo.svg?v=240820231250',N'Paribu Cineverse Gordion',N'Gordion AVM,Eskişehir Yolu 16 km,Çağlayan Kavşağı,Çayyolu/ANKARA')
insert into Cinemas(Id,Brandlogo,Name,CinemaInfo) values (6,'https://www.avsarsinema.com.tr/wp-content/uploads/2018/07/avsa-sinema-logo.png',N'Ankara Optimum Avşar',N'Optimum Alışveriş Merkezi Eryaman Ayaş Yolu N0: 93 Eryaman – ANKARA')
set identity_insert Cinemas off

set identity_insert Actors on
insert into Actors(Id,PpURL,FullName,Bio) values (1,'https://m.media-amazon.com/images/M/MV5BMTQ2MjMwNDA3Nl5BMl5BanBnXkFtZTcwMTA2NDY3NQ@@._V1_UY209_CR2,0,140,209_AL_.jpg','Tom Hanks','1956-')
insert into Actors(Id,PpURL,FullName,Bio) values (2,'https://m.media-amazon.com/images/M/MV5BMTM4MDk3OTYxOF5BMl5BanBnXkFtZTcwMDk5OTUwOQ@@._V1_UY209_CR6,0,140,209_AL_.jpg','Christoph Waltz','1956-')
insert into Actors(Id,PpURL,FullName,Bio) values (3,'https://m.media-amazon.com/images/M/MV5BMTkyNjY1NDg3NF5BMl5BanBnXkFtZTgwNjA2MTg0MzE@._V1_UY209_CR9,0,140,209_AL_.jpg','Jamie Foxx','1967-')
insert into Actors(Id,PpURL,FullName,Bio) values (4,'https://m.media-amazon.com/images/M/MV5BNDQzOTg4NzA2Nl5BMl5BanBnXkFtZTcwMzkwNjkxMg@@._V1_UY209_CR0,0,140,209_AL_.jpg', 'Viggo Mortensen','1958-')
insert into Actors(Id,PpURL,FullName,Bio) values (5,'https://m.media-amazon.com/images/M/MV5BMTQ3OTY0ODk0M15BMl5BanBnXkFtZTYwNzE4Njc4._V1_UY209_CR5,0,140,209_AL_.jpg','Jack Nicholson','1937-')
insert into Actors(Id,PpURL,FullName,Bio) values (6,'https://m.media-amazon.com/images/M/MV5BODgzMzM2NTE0Ml5BMl5BanBnXkFtZTcwMTcyMTkyOQ@@._V1_UX140_CR0,0,140,209_AL_.jpg','Kate Winslet','1975-')
insert into Actors(Id,PpURL,FullName,Bio) values (7,'https://m.media-amazon.com/images/M/MV5BMjI0MTg3MzI0M15BMl5BanBnXkFtZTcwMzQyODU2Mw@@._V1_UY209_CR7,0,140,209_AL_.jpg','Leonardo DiCaprio','1974-')
insert into Actors(Id,PpURL,FullName,Bio) values (8,'https://m.media-amazon.com/images/M/MV5BMTQzMzg1ODAyNl5BMl5BanBnXkFtZTYwMjAxODQ1._V1_UX140_CR0,0,140,209_AL_.jpg','Al Pacino','1940-')
insert into Actors(Id,PpURL,FullName,Bio) values (9,'https://m.media-amazon.com/images/M/MV5BYTFlOTdjMjgtNmY0ZC00MDgxLThjNmEtZGIxZTQyZDdkMTRjXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UY209_CR7,0,140,209_AL_.jpg','Tom Cruise','1962-')
insert into Actors(Id,PpURL,FullName,Bio) values (10,'https://m.media-amazon.com/images/M/MV5BMTkxMzk4MjQ4MF5BMl5BanBnXkFtZTcwMzExODQxOA@@._V1_UX140_CR0,0,140,209_AL_.jpg','Christian Bale','1974-')
insert into Actors(Id,PpURL,FullName,Bio) values (11,'https://m.media-amazon.com/images/M/MV5BNTU1NjM4MDYzMl5BMl5BanBnXkFtZTcwMjIwMjMyMw@@._V1_UY209_CR8,0,140,209_AL_.jpg','Jeff Bridges','1949-')
insert into Actors(Id,PpURL,FullName,Bio) values (12,'https://m.media-amazon.com/images/M/MV5BMjE5NDU2Mzc3MV5BMl5BanBnXkFtZTcwNjAwNTE5OQ@@._V1_UY209_CR8,0,140,209_AL_.jpg','Denzel Washington','1954-')
insert into Actors(Id,PpURL,FullName,Bio) values (13,'https://m.media-amazon.com/images/M/MV5BNjA0MTU2NDY3MF5BMl5BanBnXkFtZTgwNDU4ODkzMzE@._V1_UX140_CR0,0,140,209_AL_.jpg','Jake Gyllenhaal','1980-')
insert into Actors(Id,PpURL,FullName,Bio) values (14,'https://m.media-amazon.com/images/M/MV5BMTU4Mjk5MDExOF5BMl5BanBnXkFtZTcwOTU1MTMyMw@@._V1_UY209_CR4,0,140,209_AL_.jpg','Meryl Streep','1949-')
insert into Actors(Id,PpURL,FullName,Bio) values (15,'https://m.media-amazon.com/images/M/MV5BMTc1MDI0MDg1NV5BMl5BanBnXkFtZTgwMDM3OTAzMTE@._V1_UY209_CR2,0,140,209_AL_.jpg','Cate Blanchett','1969-')
insert into Actors(Id,PpURL,FullName,Bio) values (16,'https://m.media-amazon.com/images/M/MV5BMTM3MjgyOTQwNF5BMl5BanBnXkFtZTcwMDczMzEwNA@@._V1_UY209_CR1,0,140,209_AL_.jpg','Jodie Foster','1962-')
insert into Actors(Id,PpURL,FullName,Bio) values (17,'https://m.media-amazon.com/images/M/MV5BMTI5NDY5NjU3NF5BMl5BanBnXkFtZTcwMzQ0MTMyMw@@._V1_UY209_CR1,0,140,209_AL_.jpg','Sandra Bullock','1964-')
insert into Actors(Id,PpURL,FullName,Bio) values (18,'https://m.media-amazon.com/images/M/MV5BMjE1MDkxMjQ3NV5BMl5BanBnXkFtZTcwMzQ3Mjc4MQ@@._V1_UY209_CR6,0,140,209_AL_.jpg','Orlando Bloom','1977-')
insert into Actors(Id,PpURL,FullName,Bio) values (19,'https://m.media-amazon.com/images/M/MV5BZGMyY2Q4NTEtMWVkZS00NzcwLTkzNmQtYzBlMWZhZGNhMDhkXkEyXkFqcGdeQXVyNjk1MjYyNTA@._V1_UX140_CR0,0,140,209_AL_.jpg','Joaquin Phoenix','1974-')
insert into Actors(Id,PpURL,FullName,Bio) values (20,'https://m.media-amazon.com/images/M/MV5BMjA1MTQ3NzU1MV5BMl5BanBnXkFtZTgwMDE3Mjg0MzE@._V1_UY209_CR35,0,140,209_AL_.jpg','Liam Neeson','1952-')
insert into Actors(Id,PpURL,FullName,Bio) values (21,'https://m.media-amazon.com/images/M/MV5BMDUxY2M1NTQtNzcwNC00ZDljLTk4YjctYzJjZGNiYTc0YTE1XkEyXkFqcGdeQXVyMTY5MDA5MDc3._V1_UX140_CR0,0,140,209_AL_.jpg','Cillian Murphy','1976-')
insert into Actors(Id,PpURL,FullName,Bio) values (22,'https://m.media-amazon.com/images/M/MV5BMTM0NzYzNDgxMl5BMl5BanBnXkFtZTcwMDg2MTMyMw@@._V1_UY209_CR8,0,140,209_AL_.jpg','Matt Damon','1970-')
insert into Actors(Id,PpURL,FullName,Bio) values (23,'https://m.media-amazon.com/images/M/MV5BMTYwNjQ5MTI1NF5BMl5BanBnXkFtZTcwMzU5MTI2Mw@@._V1_UY209_CR11,0,140,209_AL_.jpg','Edward Norton','1969-')
set identity_insert Actors off

set identity_insert Directors on
insert into Directors(Id,PpURL,FullName,Bio) values (1,'https://m.media-amazon.com/images/M/MV5BMTgyMjI3ODA3Nl5BMl5BanBnXkFtZTcwNzY2MDYxOQ@@._V1_UX140_CR0,0,140,209_AL_.jpg','Quentin Tarantino','1963-')
insert into Directors(Id,PpURL,FullName,Bio) values (2,'https://m.media-amazon.com/images/M/MV5BMGJkOGM5OWEtNDYxMy00Njg4LWExNjAtY2ZlNWNlNzVhNDk4XkEyXkFqcGdeQXVyNDkzNTM2ODg@._V1_UX140_CR0,0,140,209_AL_.jpg','Ridley Scott','1937-')
insert into Directors(Id,PpURL,FullName,Bio) values (3,'https://m.media-amazon.com/images/M/MV5BMTgyMTEyNDgxOF5BMl5BanBnXkFtZTcwNTkzMTA3Nw@@._V1_UY209_CR8,0,140,209_AL_.jpg','Spike Lee','1957-')
insert into Directors(Id,PpURL,FullName,Bio) values (4,'https://m.media-amazon.com/images/M/MV5BZmQ2ZDNkMGYtOWUzNi00N2Q3LTk1MDItODFlNDJkMTZkMjFmXkEyXkFqcGdeQXVyMjMxNzg4Mjk@._V1_UY209_CR8,0,140,209_AL_.jpg','Adam McKay','1968-')
insert into Directors(Id,PpURL,FullName,Bio) values (5,'https://m.media-amazon.com/images/M/MV5BNTgzODMyMDUwNF5BMl5BanBnXkFtZTcwNzEyMjAyMg@@._V1_UX140_CR0,0,140,209_AL_.jpg','Sam Mendes','1965-')
insert into Directors(Id,PpURL,FullName,Bio) values (6,'https://m.media-amazon.com/images/M/MV5BYjFjOThjMjgtYzM5ZS00Yjc0LTk5OTAtYWE4Y2IzMDYyZTI5XkEyXkFqcGdeQXVyMTMxMTIwMTE0._V1_UY209_CR75,0,140,209_AL_.jpg','Peter Jackson','1961-')

set identity_insert Directors off


set identity_insert Movies on
insert into Movies(Id,Name,Description,Price,ImageURL,StartDate,FinishDate,CinemaId,DirectorId,MoviType) values (1,'Django Unchained','2012',83,'https://cdn.shopify.com/s/files/1/0057/3728/3618/products/ff35c38cb67f47a5f4cbec6c92a5d5a8_acb37f4c-8110-4bc9-b597-01e75e565a60_500x749.jpg?v=1573587558', CONVERT(datetime,'12/1/2023'),CONVERT(datetime,'2/2/2024'),3,1,1)
insert into Movies(Id,Name,Description,Price,ImageURL,StartDate,FinishDate,CinemaId,DirectorId,MoviType) values (2,'Revolutionary Road','2008',107,'https://www.movieposters.com/cdn/shop/products/8d0c493ea0331bf7a7cf9aac83313ed5_5bf59e65-37ac-4d78-8f54-0ddc8d11593e_480x.progressive.jpg?v=1573652572', CONVERT(datetime,'10/1/2023'),CONVERT(datetime,'12/1/2023'),6,5,2)
insert into Movies(Id,Name,Description,Price,ImageURL,StartDate,FinishDate,CinemaId,DirectorId,MoviType) values (3,'Dont Look Up!','2021',107,'https://www.movieposters.com/cdn/shop/files/scan002_89d275d0-0c95-40e4-9459-4eb1454db37c_480x.progressive.jpg?v=1699388759', CONVERT(datetime,'12/1/2023'),CONVERT(datetime,'2/2/2024'),4,4,4)
insert into Movies(Id,Name,Description,Price,ImageURL,StartDate,FinishDate,CinemaId,DirectorId,MoviType) values (4,'Inside Man','2006',91,'https://cdn.shopify.com/s/files/1/0057/3728/3618/products/ece57222c2ae02d6257f1676cee49346_36fd9d5e-a9d5-400a-afe1-e09e0366913c_500x749.jpg?v=1573652650', CONVERT(datetime,'12/1/2023'),CONVERT(datetime,'12/10/2023'),1,3,3)
insert into Movies(Id,Name,Description,Price,ImageURL,StartDate,FinishDate,CinemaId,DirectorId,MoviType) values (5,'Kingdom Of Heaven','Still in grief over his wife''s sudden death, village blacksmith Balian (Orlando Bloom) joins his long-estranged father, Baron Godfrey (Liam Neeson), as a crusader on the road to Jerusalem. After a perilous journey to the holy city, the valiant young man enters the retinue of the leprous King Baldwin IV (Edward Norton), which is rife with dissent led by the treacherous Guy de Lusignan (Marton Csokas), who wishes to wage war against the Muslims for his own political and personal gain.',72,'https://www.movieposters.com/cdn/shop/products/f0cd1b637f37d7cc68dacbae144ae541_6dff7ea2-e5a0-416a-b55b-d1179ae83f1d_480x.progressive.jpg?v=1573653930', CONVERT(datetime,'2/5/2024'),CONVERT(datetime,'4/5/2024'),5,2,1)
insert into Movies(Id,Name,Description,Price,ImageURL,StartDate,FinishDate,CinemaId,DirectorId,MoviType) values (6,'The Lord of the Rings: The Return of the King','The culmination of nearly 10 years work and conclusion to Peter Jackson''s epic trilogy based on the timeless J.R.R. Tolkien classic, The Lord of the Rings: The Return of the King presents the final confrontation between the forces of good and evil fighting for control of the future of Middle-earth. Hobbits Frodo and Sam reach Mordor in their quest to destroy the one ring, while Aragorn leads the forces of good against Sauron s evil army at the stone city of Minas Tirith.',100,'https://cdn.shopify.com/s/files/1/0057/3728/3618/products/544fbfc37d3def7c758e0620a9ad2fd8_10a2cdea-1696-40d9-bd33-af7335a5b5a0_500x749.jpg?v=1573588792', CONVERT(datetime,'12/1/2023'),CONVERT(datetime,'3/10/2024'),2,6,1)

set identity_insert Movies off



insert into Actors_Movies(MovieId,ActorId) values(1,2)
insert into Actors_Movies(MovieId,ActorId) values(1,3)
insert into Actors_Movies(MovieId,ActorId) values(1,7)

insert into Actors_Movies(MovieId,ActorId) values(2,7)
insert into Actors_Movies(MovieId,ActorId) values(2,6)

insert into Actors_Movies(MovieId,ActorId) values(3,7)
insert into Actors_Movies(MovieId,ActorId) values(3,14)
insert into Actors_Movies(MovieId,ActorId) values(3,15)

insert into Actors_Movies(MovieId,ActorId) values(4,16)
insert into Actors_Movies(MovieId,ActorId) values(4,12)

insert into Actors_Movies(MovieId,ActorId) values(5,18)
insert into Actors_Movies(MovieId,ActorId) values(5,20)
insert into Actors_Movies(MovieId,ActorId) values(5,23)

insert into Actors_Movies(MovieId,ActorId) values(6,18)
insert into Actors_Movies(MovieId,ActorId) values(6,15)
insert into Actors_Movies(MovieId,ActorId) values(6,4)
























