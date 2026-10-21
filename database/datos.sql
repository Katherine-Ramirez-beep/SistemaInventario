use SistemaInventario;
go

insert into Categorias (Nombre, Descripcion) values
('Electrónica', 'Dispositivos electrónicos y accesorios'),
('Papelería', 'Artículos de oficina y útiles escolares'),
('Mobiliario', 'Muebles y sillas ergonómicas'),
('Limpieza', 'Productos de higiene y mantenimiento'),
('Alimentos & Bebidas', 'Snacks y bebidas para oficina');
go

insert into Suplidores (NombreEmpresa, NombreContacto, Telefono, CorreoEmail) values
('TechSupplies RD', 'Carlos Martínez', '809-567-0123', 'contactotechsupplies@gmail.com'),
('Distribuidora El Sol', 'Ana Gómez', '829-875-0092', 'ventaselsol@gmail.com'),
('OfiMuebles Corp', 'Luis Fernández', '849-095-0873', 'servicioofimuebles@gmail.com'),
('Suministros Higiénicos SRL', 'María Rodríguez', '809-555-0404', 'mrodriguezsumihig@gmail.com'),
('Comercializadora Del Caribe', 'José López', '829-234-1234', 'caribecomercial@gmail.com');
go

insert into Productos (Nombre, PrecioUnitario, CategoriaId, SuplidorId) values
('Mouse Inalámbrico Logitech', 1250.00, 1, 1),
('Teclado Mecánico RGB', 3450.50, 1, 1),
('Monitor LED 24 Pulgadas', 8900.00, 1, 1),
('Cable HDMI 2.0', 450.00, 1, 1),
('Disco Duro Externo 1TB', 4200.00, 1, 1),
('Caja de Hojas Carta', 320.00, 2, 2),
('Paquete Lapiceros Azules', 180.00, 2, 2),
('Grapadora Uso Pesado', 650.00, 2, 2),
('Archivador de Palanca', 240.00, 2, 2),
('Silla Ergonómica', 11500.00, 3, 3),
('Escritorio Ejecutivo', 24500.00, 3, 3),
('Lámpara LED', 1200.00, 3, 3),
('Desinfectante Multiuso', 480.00, 4, 4),
('Paquete Papel Toalla', 890.00, 4, 4),
('Jabón Líquido 500ml', 210.00, 4, 4),
('Caja de Mascarillas', 350.00, 4, 4),
('Café Molido 1lb', 380.00, 5, 5),
('Caja de Agua Embotellada', 420.00, 5, 5),
('Azúcar Crema 5lbs', 220.00, 5, 5),
('Surtido de Galletas', 310.00, 5, 5);
go