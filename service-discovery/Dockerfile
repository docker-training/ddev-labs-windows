FROM stefanscherer/python-windows:3.6.1-nano
WORKDIR /app
COPY requirements.txt /app/
RUN pip install -r requirements.txt
COPY . /app
EXPOSE 3000
CMD python server.py