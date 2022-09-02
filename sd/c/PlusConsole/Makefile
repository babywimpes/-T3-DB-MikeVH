PROD_DIR := ./product
BUILD_DIR :=./build

PROD_EXEC = plus
PROD_DIRS := $(PROD_DIR)
PROD_FILES := $(wildcard $(patsubst %,%/*.c, $(PROD_DIRS)))
HEADER_PROD_FILES := $(wildcard $(patsubst %,%/*.h, $(PROD_DIRS)))
PROD_INC_DIRS=-I$(PROD_DIR)

CC=gcc
SYMBOLS=-Wall -Werror -g -pedantic -O0 -std=c99

.PHONY: clean

all: $(PROD_EXEC)

$(PROD_EXEC): Makefile $(PROD_FILES)  $(HEADER_FILES)
	@$(CC) $(PROD_INC_DIRS) $(SYMBOLS) $(PROD_FILES) -o $(BUILD_DIR)/$(PROD_EXEC)

run: $(PROD_EXEC)
	@./$(BUILD_DIR)/$(PROD_EXEC)

clean:
	rm -rf $(BUILD_DIR)/$(PROD_EXEC)*
