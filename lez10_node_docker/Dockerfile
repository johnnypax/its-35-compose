FROM node:24.16-alpine

WORKDIR /app

COPY . ./

RUN npm install --omit=dev

EXPOSE 3000

CMD ["node", "app.js"]