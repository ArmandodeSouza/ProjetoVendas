CREATE DATABASE "ProjetoVendas"
    WITH
    OWNER = postgres
    TEMPLATE = template0
    ENCODING = 'WIN1252'
    STRATEGY = 'wal_log'
    LOCALE_PROVIDER = 'libc'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;

CREATE TABLE clientes (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(150) NOT NULL UNIQUE,
    telefone VARCHAR(20)
);

CREATE INDEX idx_cliente_email ON clientes(email);

CREATE TABLE produtos (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    descricao TEXT,
    preco NUMERIC(10,2) NOT NULL CHECK (preco > 0),
    estoque INT NOT NULL CHECK (estoque >= 0)
);

CREATE INDEX idx_produto_nome ON produtos(nome);

CREATE TABLE vendas (
    id SERIAL PRIMARY KEY,
    cliente_id INT NOT NULL,
    data_venda TIMESTAMP NOT NULL DEFAULT NOW(),
    total NUMERIC(12,2) NOT NULL,
    CONSTRAINT fk_venda_cliente
        FOREIGN KEY (cliente_id) REFERENCES clientes(id)
);

CREATE TABLE venda_itens (
    id SERIAL PRIMARY KEY,
    venda_id INT NOT NULL,
    produto_id INT NOT NULL,
    quantidade INT NOT NULL CHECK (quantidade > 0),
    preco_unitario NUMERIC(10,2) NOT NULL,
    CONSTRAINT fk_item_venda FOREIGN KEY (venda_id) REFERENCES vendas(id),
    CONSTRAINT fk_item_produto FOREIGN KEY (produto_id) REFERENCES produtos(id)
);