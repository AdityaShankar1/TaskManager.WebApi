# Task Manager Dashboard

A full‑stack task management application with:
- ✅ ASP.NET Core backend (REST API)
- ✅ React + Vite frontend with Chart.js dashboards
- ✅ Dockerized deployment (backend, frontend, DB)
- ⚡ PostgreSQL service included in Docker Compose (future persistence)

---

## 🚀 Features
- Add, toggle, and delete tasks
- Manual priority assignment (1–3)
- Dashboard with:
  - Summary cards (Total, Completed, Pending, Due Soon)
  - Pie chart (Completed vs Pending)
  - Bar chart (Tasks by Priority)
- Docker Compose for one‑command startup
- **Note:** Tasks are currently stored in memory. PostgreSQL container is included for future integration.

---

## 🛠️ Tech Stack
- **Backend**: ASP.NET Core 8.0
- **Frontend**: React + Vite + Chart.js
- **Database**: PostgreSQL 15 (planned integration)
- **Deployment**: Docker & Docker Compose

---

## 📂 Project Structure
---

##  Project Structure:

TaskManagerApi/
 ├── TaskManagerApi/          # ASP.NET Core backend
 │    └── Dockerfile
 ├── taskmanager-frontend/    # React frontend
 │    └── Dockerfile
 └── docker-compose.yml       # Compose file for backend+frontend+db

### 📷 Output Screenshot
<img width="1470" height="956" alt="Screenshot 2025-12-15 at 12 00 58 AM" src="https://github.com/user-attachments/assets/38772c2c-f4d7-432b-854d-be11cda91783" />
