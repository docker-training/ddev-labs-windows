#TODO
FROM stefanscherer/node-windows:8.4.0-nano

WORKDIR /app
COPY package.json .
RUN npm install
COPY ./src ./src
EXPOSE 3000
CMD npm start
