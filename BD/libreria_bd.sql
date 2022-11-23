
use grupo5;
desc product;

create database grupoIspc


select * from order_detail;order_detail













SELECT COUNT(28115617) FROM usuario;
SELECT COUNT('22')  FROM prestamo;
select * from usuario;
update usuario set estadoUsuario='0' where id_usuario='6';

select COUNT(DniUsuario) as cont from prestamo INNER JOIN usuario On prestamo.idUsuario=usuario.id_usuario where estadoUsuario=1 and prestamo.mora>0 and DniUsuario=28115617;


select * from prestamo;

INSERT INTO `libreria_bd`.`editorial` (`Editorial`) 
VALUES 
('Franz Kafka');
select * from editorial;

select idEditorial,Editorial from editorial order by idEditorial asc
INSERT INTO `libreria_bd`.`autor` (`nombreAutor`) 
VALUES 
('Franz Kafka');
select * from autor;

INSERT INTO `libreria_bd`.`idioma` (`Idioma`) 
VALUES 
('Español');
select * from idioma;


INSERT INTO `libreria_bd`.`categoria` (`Categoria`) 
VALUES 
('Biología');
select * from categoria;

INSERT INTO `libreria_bd`.`estado` (`Estado`) 
VALUES 
('Disponible');
select * from estado;

INSERT INTO `libreria_bd`.`libros` (`titulo`, `id_autor`,`id_editor`, `fechaPublic`, `edicion`, `id_categoria`, `id_idioma`, `pagina`, `id_estado`, `notas`, `stock`, `condicionLibro`) 
VALUES 
('Historia Argentina', '1', '1', '1990/05/01', 'blanda', '2', '1', '288', '1', 'no', '1', '1');
select * from usuario;

select idLibros,titulo,nombreAutor,Editorial,fechaPublic,edicion,Categoria,Idioma,pagina,Estado,notas,stock,condicionLibro from libros 
INNER JOIN categoria On libros.id_categoria = categoria.idCategoria
INNER JOIN autor On libros.id_autor = autor.idAutor
INNER JOIN editorial On libros.id_editor = editorial.idEditorial
INNER JOIN idioma On libros.id_idioma = idioma.idIdioma
INNER JOIN estado On libros.id_estado = estado.idEstado


where libros.idLibros =0 || libros.titulo="Gabrddiel" || autor.nombreAutor="Gabrddiel" || idioma.Idioma="Espssañol" || categoria.Categoria="Religion" || editorial.Editorial="Religion";


select idPrestamo,NombreUsuario,ApellidoUsuario,titulo,fechaSalida,fechaEntrega from prestamo 
INNER JOIN usuario On prestamo.idUsuario = usuario.id_usuario
INNER JOIN libros On prestamo.idLibro = alibros.idLibros;

update libros set stock='11' where idLibros=2;

select * from libros where titulo like '%la%';


select * from libros;

show global variables like 'PORT';