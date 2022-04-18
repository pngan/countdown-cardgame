# Countdown Card Game



## Build Docker Image
```bash
cd  <repo_root\Countdown-CardGame>
docker image build -t <dockerId>/countdowncardgameserver -f .\Server\Dockerfile .
```

## Run docker Image locally

```bash
docker run -p 80:80 <dockerId>/countdowncardgameserver
```
Use browser to navigate to `http://localhost`

## Upload image to docker hub

```bash
docker push  <dockerId>/countdowncardgameserver
```
