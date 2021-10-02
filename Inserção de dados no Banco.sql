INSERT INTO Usuarios (Nome, Sobrenome, Email, Telefone, DataNasc) 
VALUES (
	'Rodrigo',
	'Wasem',
	'igowasem@gmail.com',
	'051995465074',
	'1993-10-25'
);

INSERT INTO Usuarios (Nome, Sobrenome, Email, Telefone, DataNasc) 
VALUES (
	'Teste',
	'Teste2',
	'teste@teste.com',
	'051995465075',
	'1994-10-25'
);

SELECT * FROM Usuarios;

INSERT INTO Categorias (Nome) 
VALUES (
	'Diversos'
);

SELECT * FROM Categorias;

INSERT INTO Itens (Nome, CategoriaId, Disp_Emprestimo) 
VALUES (
	'Reboque',
	1,
	'true'
);

SELECT * FROM Itens



INSERT INTO Emprestimos (UsuarioId, ItemId, Data_Emprestimo) 
VALUES (
	2,
	1,
	'2021-10-01'
);