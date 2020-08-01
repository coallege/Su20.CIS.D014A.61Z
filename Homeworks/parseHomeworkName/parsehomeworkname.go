package main

import (
	"fmt"
	"strings"
)

func parse(input string) (output string, err error) {
	if input == "" {
		return "", nil
	}

	var parts = strings.Split(input, "_")
	var partcount = len(parts)
	if partcount == 0 {
		return "", nil
	}

	var sb strings.Builder
	sb.Grow(64)

	// Ex1
	if partcount > 0 {
		if _, err = sb.WriteString("chapter "); err != nil {
			return "", err
		}
		chapter := parts[0]
		if strings.HasPrefix(chapter, "Ex") {
			chapter = chapter[2:]
		}
		if _, err = sb.WriteString(chapter); err != nil {
			return "", err
		}
	}

	// Ex1_2
	if partcount > 1 {
		if _, err = sb.WriteString(", section "); err != nil {
			return sb.String(), err
		}
		if _, err = sb.WriteString(parts[1]); err != nil {
			return sb.String(), err
		}
	}

	// Ex1_2_3_...
	if partcount > 2 {
		if _, err = sb.WriteString(", exercise "); err != nil {
			return sb.String(), err
		}
	}

	// Ex1_2_3
	if partcount == 3 {
		_, err = sb.WriteString(parts[2])
	}

	// Ex1_2_3_4
	if partcount == 4 {
		_, err = fmt.Fprintf(&sb, "%s and %s", parts[2], parts[3])
	}

	// Ex1_2_3_4_5...
	if partcount > 4 {
		_, err = fmt.Fprintf(
			&sb,
			"%s, and %s ",
			strings.Join(parts[2:], ", "),
			parts[partcount-1],
		)
	}

	return sb.String(), err
}
