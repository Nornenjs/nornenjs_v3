cmd_Release/obj.target/cuda.node := flock ./Release/linker.lock g++ -shared -pthread -rdynamic -m32 -L/usr/local/lib  -Wl,-soname=cuda.node -o Release/obj.target/cuda.node -Wl,--start-group Release/obj.target/cuda/src/bindings.o Release/obj.target/cuda/src/ctx.o Release/obj.target/cuda/src/device.o Release/obj.target/cuda/src/function.o Release/obj.target/cuda/src/mem.o Release/obj.target/cuda/src/module.o -Wl,--end-group -lcuda