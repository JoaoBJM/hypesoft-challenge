# Hypesoft Challenge

> Sistema completo de gestão de produtos, desenvolvido como desafio técnico para a Hypesoft, utilizando arquitetura moderna, boas práticas e tecnologias de ponta.

---

## 🚀 Visão Geral
Este projeto foi desenvolvido do zero, com foco em Clean Architecture, escalabilidade, segurança e experiência do usuário. O objetivo é demonstrar domínio em backend, frontend e infraestrutura moderna.

## 🛠️ Tecnologias & Decisões

### Backend (.NET 9)
- **Clean Architecture + DDD:** Separação clara de responsabilidades, facilitando manutenção e testes.
- **CQRS + MediatR:** Comandos e queries desacoplados, facilitando escalabilidade e rastreabilidade.
- **Entity Framework Core (MongoDB):** Persistência flexível e performática.
- **FluentValidation & AutoMapper:** Validação robusta e mapeamento eficiente.
- **Serilog:** Logging estruturado para observabilidade.
- **xUnit + FluentAssertions:** Testes unitários e integração com alta cobertura.

### Frontend (Next.js 14 + React 18)
- **Next.js App Router:** SSR, code splitting e performance.
- **TailwindCSS + Shadcn/ui:** UI moderna, responsiva e consistente.
- **React Query:** Gerenciamento eficiente de dados e cache.
- **React Hook Form + Zod:** Formulários com validação em tempo real.
- **Recharts/Chart.js:** Dashboards e visualização de dados.
- **Vitest + React Testing Library:** Testes rápidos e confiáveis.

### Infraestrutura
- **Docker Compose:** Orquestração de todos os serviços (API, frontend, MongoDB, Keycloak, Nginx).
- **Keycloak:** Autenticação e autorização robusta (OAuth2/OpenID Connect).
- **Nginx:** Reverse proxy para segurança e performance.

## 📐 Arquitetura

```
backend/
  src/
	 Hypesoft.Domain/         # Entidades, VOs, eventos, repositórios
	 Hypesoft.Application/    # CQRS, DTOs, validações, handlers
	 Hypesoft.Infrastructure/ # Data, repositórios, serviços externos
	 Hypesoft.API/            # Controllers, middlewares, filtros
frontend/
  src/
	 components/  pages/  hooks/  services/  stores/  types/  utils/  lib/
```

## 💡 Como foi feito
- **Planejamento:** Análise dos requisitos, definição da arquitetura e escolha das tecnologias.
- **Setup:** Estruturação dos projetos backend e frontend, configuração do Docker Compose e Nginx.
- **Backend:** Implementação das camadas, entidades, repositórios, comandos/queries, validações e testes.
- **Frontend:** Criação da base Next.js, configuração de UI, autenticação, páginas e integração com API.
- **Infra:** Configuração de Keycloak, MongoDB, variáveis de ambiente e scripts de inicialização.
- **Testes:** Cobertura mínima de 85% no backend, testes E2E e integração.
- **Documentação:** README detalhado, exemplos de uso, instruções de setup e arquitetura.

## 🏁 Como rodar localmente

1. Clone o repositório:
	```sh
	git clone https://github.com/JoaoBJM/hypesoft-challenge.git
	cd hypesoft-challenge
	```
2. Copie as variáveis de ambiente:
	```sh
	cp .env.example .env
	```
3. Suba os containers:
	```sh
	docker-compose up -d
	```
4. Acesse os serviços:
	- Frontend: http://localhost:3000
	- API: http://localhost:5000
	- Swagger: http://localhost:5000/swagger
	- MongoDB Express: http://localhost:8081
	- Keycloak: http://localhost:8080

## 📋 Funcionalidades
- CRUD de produtos e categorias
- Busca, filtro e dashboard
- Controle e alerta de estoque
- Autenticação Keycloak (roles)
- Testes automatizados e documentação

## 📄 Licença
MIT

---

Desenvolvido por [João BJM](https://github.com/JoaoBJM) para o desafio Hypesoft 🚀
