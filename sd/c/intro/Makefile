ASSIGNMENT=main
ASSIGNMENT_TEST=main_test

UNITY_FOLDER=Unity
INC_DIRS=-Iproduct
TEST_INC_DIRS=$(INC_DIRS) -I$(UNITY_FOLDER)

SHARED_FILES=product/challenge.c

PRODUCT_FILES=$(SHARED_FILES) \
	            product/main.c \
	            product/realtime.c\
				product/parser.c

TEST_FILES=$(SHARED_FILES) \
	        $(UNITY_FOLDER)/unity.c \
	        test/challenge_test.c

HEADER_FILES=product/*.h

CC=gcc

#SYMBOLS=-g  -O0 -std=c99 -Wall -Werror -pedantic
SYMBOLS=-g -O3 -Wall -Werror -pedantic

TEST_SYMBOLS=$(SYMBOLS) -DTEST

.PHONY: clean $(ASSIGNMENT) $(ASSIGNMENT_TEST)

all: $(ASSIGNMENT)

$(ASSIGNMENT): Makefile $(PRODUCT_FILES)  $(HEADER_FILES)
	$(CC) $(INC_DIRS) $(SYMBOLS) $(PRODUCT_FILES) -o $(ASSIGNMENT)

$(ASSIGNMENT_TEST): Makefile $(TEST_FILES)  $(HEADER_FILES)
	$(CC) $(TEST_INC_DIRS) $(TEST_SYMBOLS) $(TEST_FILES) -o $(ASSIGNMENT_TEST)

test: $(ASSIGNMENT_TEST)
	@./$(ASSIGNMENT_TEST)

clean:
	@rm -rf $(ASSIGNMENT) $(ASSIGNMENT).dSYM $(FILE_ELEMENT_TEST) $(ASSIGNMENT_TEST)
