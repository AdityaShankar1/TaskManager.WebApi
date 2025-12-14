# Build stage
FROM node:20 AS build
WORKDIR /app
COPY . .
RUN npm install
RUN npm run build

# Serve stage
FROM nginx:alpine
WORKDIR /usr/share/nginx/html
COPY --from=build /app/dist .
