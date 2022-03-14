FROM node:16
# Creo una cartella sul container
WORKDIR /usr/src/app
COPY package.json ./
RUN npm install
COPY . .
EXPOSE 8080
CMD ["node", "index.js"]