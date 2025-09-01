# Hypesoft Challenge

## Visão Geral

Este projeto é um sistema completo de gestão de produtos, desenvolvido como desafio técnico para a Hypesoft. Ele demonstra arquitetura moderna, boas práticas de desenvolvimento e uso de tecnologias de ponta.

## Funcionalidades
- **Gestão de Produtos:** CRUD de produtos, busca, filtro por categoria, controle de estoque, alerta de estoque baixo.
- **Sistema de Categorias:** CRUD de categorias, associação produto-categoria.
- **Dashboard:** Total de produtos, valor do estoque, produtos com estoque baixo, gráfico por categoria.
- **Autenticação:** Integração com Keycloak (OAuth2/OpenID Connect), proteção de rotas, roles.

## Tecnologias Utilizadas
### Backend
- .NET 9, Clean Architecture, DDD, CQRS, MediatR
- Entity Framework Core (MongoDB provider)
- FluentValidation, AutoMapper, Serilog
- xUnit, FluentAssertions

### Frontend
- Next.js 14 (App Router, SSR)
- React 18, TypeScript
- TailwindCSS, Shadcn/ui
- React Query, React Hook Form, Zod
- Recharts/Chart.js
- React Testing Library, Vitest

### Infraestrutura
- MongoDB, Keycloak, Docker Compose, Nginx

## Como Executar

```sh
git clone https://github.com/seu-usuario/hypesoft-challenge.git
cd hypesoft-challenge
cp .env.example .env
docker-compose up -d
docker-compose ps
```

- Frontend: http://localhost:3000
- API: http://localhost:5000
- Swagger: http://localhost:5000/swagger
- MongoDB Express: http://localhost:8081
- Keycloak: http://localhost:8080

## Estrutura do Projeto

```
backend/
	src/
		Hypesoft.Domain/
		Hypesoft.Application/
		Hypesoft.Infrastructure/
		Hypesoft.API/
frontend/
	src/
		components/
		pages/
		hooks/
		services/
		stores/
		types/
		utils/
		lib/
```

## Licença
MIT
