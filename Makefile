DOTNET := $(shell which dotnet)

PRJ = main
BIN = $(PRJ).exe
SRC = $(PRJ).fs

ifneq (, $(DOTNET))
RUN = ./$(BIN)
else
FSC = fsharpc
RUN = mono ./$(BIN)
endif

all: $(BIN)

$(BIN): $(SRC)
ifneq (, $(DOTNET))
	dotnet build $(PRJ).fsproj
ifeq (,$(wildcard ./$(BIN)))
	@ln -s bin/Debug/net5.0/$(PRJ) $(BIN)
	@ln -s bin/Debug/net5.0/$(PRJ).dll .
	@ln -s bin/Debug/net5.0/FSharp.Core.dll .
endif
else
	$(FSC) --lib:. -r Expecto.dll --out:$(BIN) $(SRC) tests.fs
endif

clean:
ifneq (, $(DOTNET))
	@unlink $(PRJ).dll | true
	@unlink FSharp.Core.dll | true
	@rm -rf bin obj | true
endif
	rm -rf $(BIN) | true

.PHONY: all clean test

test: $(BIN)
	$(RUN)

d1: $(BIN)
	$(RUN) --filter-test-case d1

d2: $(BIN)
	$(RUN) --filter-test-case d2

d3: $(BIN)
	$(RUN) --filter-test-case d3

d4: $(BIN)
	$(RUN) --filter-test-case d4

d5: $(BIN)
	$(RUN) --filter-test-case d5

d6: $(BIN)
	$(RUN) --filter-test-case d6

d7: $(BIN)
	$(RUN) --filter-test-case d7

d8: $(BIN)
	$(RUN) --filter-test-case d8

d9: $(BIN)
	$(RUN) --filter-test-case d9

d10: $(BIN)
	$(RUN) --filter-test-case d10

d11: $(BIN)
	$(RUN) --filter-test-case d11

w1: $(BIN)
	$(RUN) --filter-test-case w1

w2: $(BIN)
	$(RUN) --filter-test-case w2

w3: $(BIN)
	$(RUN) --filter-test-case w3

w4: $(BIN)
	$(RUN) --filter-test-case w4

w5: $(BIN)
	$(RUN) --filter-test-case w5

w6: $(BIN)
	$(RUN) --filter-test-case w6

w7: $(BIN)
	$(RUN) --filter-test-case w7

