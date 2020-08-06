package main

import (
	"fmt"
	"strings"
)

func fpart(input string) string {
	if input == "" {
		return "?"
	}
	return input
}

func parse(input string) (output string, err error) {
	if input == "" {
		return "", nil
	}

	parts := strings.Split(input, "_")
	partcount := len(parts)
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
		chapter = fpart(chapter)
		if _, err = sb.WriteString(chapter); err != nil {
			return "", err
		}
	}

	// Ex1_2
	if partcount > 1 {
		if _, err = sb.WriteString(", section "); err != nil {
			return sb.String(), err
		}

		section := fpart(parts[1])
		if _, err = sb.WriteString(section); err != nil {
			return sb.String(), err
		}
	}

	// Ex1_2_3
	if partcount == 3 {
		if _, err = sb.WriteString(", exercise "); err != nil {
			return sb.String(), err
		}
		part2 := fpart(parts[2])
		_, err = sb.WriteString(part2)
		return sb.String(), err
	}

	if partcount > 3 {
		if _, err = sb.WriteString(", exercises "); err != nil {
			return sb.String(), err
		}
	}

	// Ex1_2_3_4
	if partcount == 4 {
		part2 := fpart(parts[2])
		part3 := fpart(parts[3])
		_, err = fmt.Fprintf(&sb, "%s and %s", part2, part3)
	}

	// Ex1_2_3_4_5...
	if partcount > 4 {
		lastpart := fpart(parts[partcount-1])

		exercises := make([]string, partcount-4)
		for idx, part := range parts[2 : partcount-2] {
			exercises[idx] = fpart(part)
		}

		_, err = fmt.Fprintf(
			&sb,
			"%s, and %s ",
			strings.Join(exercises, ", "),
			lastpart,
		)
	}

	return sb.String(), err
}
