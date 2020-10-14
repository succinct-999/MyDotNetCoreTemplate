kubectl create -f k8s-web-pod.yaml
kubectl create -f k8s-net-service.yaml
kubectl create -f k8s-net-replicaset.yaml
kubectl expose replicaset k8s-net-replicaset --type=LoadBalancer --port=8091 --target-port=80 --name k8s-net-rs -service
pause